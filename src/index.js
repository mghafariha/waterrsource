import React from 'react';
import ReactDOM from 'react-dom';
import {Provider} from 'react-redux';
import store from './store'
import {Form} from './Form';
import { BrowserRouter } from "react-router-dom";
import 'font-awesome/css/font-awesome.min.css';

ReactDOM.render(<BrowserRouter><Provider store={store}>
<Form /></Provider></BrowserRouter>, document.getElementById('root'));

