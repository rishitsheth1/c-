//Load the index controller
var index = require('../../app/controllers/index.server.controller');
// Load the 'tasks' controller
var surveys = require('../../app/controllers/surveys.server.controller');

// Define the routes module' method
module.exports = function (app) {
    // Set up the 'users' base routes
    //
    //show the 'index' page if a GET request is made to root
    app.route('/').get(index.render);
    //show the 'add_task' page if a GET request is made to /tasks
    app.route('/surveys').get(index.renderAdd);

    // a post request to /tasks will execute createTask method in tasks.server.controller
    app.route('/surveys').post(surveys.createSurvey);
    app.route('/list_surveys').get(surveys.readSurvey);

    app.route('/update_survey').get(index.getUpdatePage);
    app.route('/update_survey').post(surveys.update);

    app.route('/delete_survey').get(surveys.showDeletePage);
    app.route('/delete').post(surveys.deleteBySurveyId);

};
