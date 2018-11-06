import React from 'react';
import { Link, Route } from 'react-router-dom';

import Profile from './Forms/Well/Profile';
import Visit from './Forms/Well/Visit';
import Home from './Home';
import Violation from './Forms/Well/Violation';





export class Form extends React.Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div>

              
                 {/* <Route path="/Violation" component={Workflow} /> */}
<br/>
                <div className="row">
                    <div className="col-sm-6 col-md-3 fRight" >
                        <div className="panel panel-primary">
                            <div className="panel-heading">
                                <h3 className="panel-title">چاه</h3>
                            </div>
                            <div className="panel-body">
                                <ul>
                                
                                <li><Link to="/Profile">اطلاعات شناسنامه ای</Link></li>
                                
                                    
                                    <li><Link to="/Visit">اطلاعات بازدید </Link></li>
                                    <li><Link to="/Violation">تخلفات</Link></li>
                                    <li>گزارشات</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div className="col-sm-6 col-md-3 fRight">
                        <div className="panel panel-primary">
                            <div className="panel-heading">
                                <h3 className="panel-title ">چشمه</h3>
                            </div>
                            <div className="panel-body">
                                <ul>
                                    <li>اطلاعات شناسنامه ای</li>
                                    <li>اطلاعات بازدید </li>
                                    <li>تخلفات</li>
                                    <li>گزارشات</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div className="col-sm-6 col-md-3 fRight">
                        <div className="panel panel-primary">
                            <div className="panel-heading">
                                <h3 className="panel-title ">قنات</h3>
                            </div>
                            <div className="panel-body">
                                <ul>
                                <li>اطلاعات شناسنامه ای</li>
                                    <li>اطلاعات بازدید </li>
                                    <li>تخلفات</li>
                                    <li>گزارشات</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div className="col-sm-6 col-md-3 fRight">
                        <div className="panel panel-primary">
                            <div className="panel-heading">
                                <h3 className="panel-title ">دستگاه حفاری</h3>
                            </div>
                            <div className="panel-body">
                                <ul>
                                
                                    <li>اطلاعات بازدید </li>
                                    <li>تخلفات</li>
                                    <li>گزارشات</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <Route path="/Home" component={Home} />
                <Route path="/Profile" component={Profile} />
                <Route path="/Visit" component={Visit} />
                <Route path="/Violation" component={Violation} />
            </div>

            // <div className='form'>

            //     {/* <ItemForm/> */}
            //     <br/>
            //     <Visit  />
            //     </div>


        )
    }
}
