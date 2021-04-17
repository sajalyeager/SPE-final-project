import React from "react";
import '../css/RegisterScreen.css'
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link
} from "react-router-dom";

import Status from "./status";
import Provider from "./Providerchoices";

const providerscreen = ({Account, Contract}) => {

        return(
            <Router>
                <div>
                        <ul>
                            <li>
                                Please click on the links below to choose your category:
                            </li>
                            <li>
                                <Link to="/status">change the status</Link>
                            </li>
                            <li>
                                <Link to = "/user">select the user</Link>
                            </li>

                        </ul>
         

                    {/* A <Switch> looks through its children <Route>s and
            renders the first one that matches the current URL. */}
                    <Switch>

                        <Route path="/status">
                            <Status contract ={Contract} account={Account}/>
                        </Route>
                        <Route path = "/user">
                            <Provider contract ={Contract} account={Account} />
                        </Route>
                    </Switch>
                </div>
            </Router>
  )
}

export default providerscreen;