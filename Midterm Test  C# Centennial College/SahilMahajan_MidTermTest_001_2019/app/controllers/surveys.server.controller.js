// Load the 'Task' Mongoose model
var Survey = require('mongoose').model('Survey');

// Create a new 'createTask' controller method
exports.createSurvey = function (req, res, next) {
    // Create a new instance of the 'Task' Mongoose model
    var survey = new Survey(req.body);
    // Use the 'Task' instance's 'save' method to save a new task document
    survey.save(function (err) {
        if (err) {
            // Call the next middleware with an error message
            return next(err);
        } else {
            // Use the 'response' object to send a JSON response
            res.json(survey);

        }
    });
};
// Create a new 'readTasks' controller method
exports.readSurvey = function (req, res, next) {
    console.log('in readTasks');
    // Use the 'Task' static 'find' method to retrieve the list of items
    Survey.find({}, function (err, tasks) {
        console.log(tasks);
        if (err) {
            // Call the next middleware with an error message
            console.log('some error in readTask method');
            return next(err);
        } else {
            //
            res.render('tasks', {
                title: 'survey',
                tasks: tasks
            });
        }
    });
};

exports.update = function (req, res, next) {
 
    req.user = req.body; //read the user from request's body
    console.log(req.user);
    //initialize findOneAndUpdate method arguments
    var query = { "surveyId": req.user.surveyId };
    var updateSurvey = req.body;
    var options = { new: true };

    // Use the 'User' static 'findOneAndUpdate' method to update a specific user by user name
    Survey.findOneAndUpdate(query, updateSurvey, options, (err, student) => {
        if (err) {
            // Call the next middleware with an error message
            return next(err);
        } else {
            // Use the 'response' object to send a JSON response
            //res.json(user);
            res.redirect('/'); //display all users
        }
    });
};

exports.showDeletePage = function (req, res) {

    // Use the 'response' object to show the delete_user page
    res.render('delete_survey', {
        title: 'Delete Survey'
    });

};

exports.deleteBySurveyId = function (req, res, next) {
    //
    console.log(req.body.username);
    Survey.findOneAndRemove({
        surveyId: req.body.surveyId
    }, function (err, user) {
        if (err) throw err;
        console.log("Success");
    });

    res.redirect('/');
};
