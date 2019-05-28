 const mongoose = require('mongoose');
const Schema = mongoose.Schema;
const ArticleSchema = new Schema({

    section: String,
    semester: String,

    code: {
        type: String,
        default: '',
        trim: true,
        required: 'Code cannot be blank'
    },
    courseName: {
        type: String, default: '',
        trim: true
    },
    created: {
        type: Date,
        default: Date.now
    },
    title: {
        type: String,
        default: '',
        trim: true,
     
    },
    content: {
        type: String, default: '',
        trim: true
    },
    creator: {
        type: Schema.ObjectId,
        ref: 'User'
    }
});
mongoose.model('Article', ArticleSchema);
