// Load the Mongoose module and Schema object
var mongoose = require('mongoose'),
    Schema = mongoose.Schema;
// Define a new 'TaskSchema'
var SurveySchema = new Schema({
    surveyId : { type: String, unique: true, required: true },
    gameGenre : String,
    daysPerYear: Number,
    age : String
});
// Create the 'Task' model out of the 'TaskSchema'
mongoose.model('Survey', SurveySchema);
