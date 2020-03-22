import * as React from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { Spinner } from "./layouts/spinner";

const Login = React.lazy(() => import("./pages/login"));
const Home = React.lazy(() => import("./pages/home"));
const PermissionDenied = React.lazy(() => import("./pages/error/permission-denied"));
const NotFound = React.lazy(() => import("./pages/error/not-found"));

export default class Routing extends React.Component {
  render() {
    return (
      <BrowserRouter>
        <React.Suspense fallback={<Spinner />}>
          <Switch>
            <Route exact path="/">
              <Redirect to="/home" />
            </Route>
            <Route path="/login" render={props => <Login {...props} />} />
            <Route path="/home" render={props => <Home {...props} />} />

            <Route path="/permission-denied" render={props => <PermissionDenied {...props} />} />
            <Route render={props => <NotFound {...props} />} />
          </Switch>
        </React.Suspense>
      </BrowserRouter>
    );
  }
}
