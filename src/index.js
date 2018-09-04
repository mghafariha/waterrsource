import React from 'react';
import ReactDOM from 'react-dom';
import {Provider} from 'react-redux';
import store from './store'
import './index.css';
import {Form} from './Form';


ReactDOM.render(<Provider store={store}>
<Form /></Provider>, document.getElementById('root'));

