import React, { Component } from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { Spinner } from "./spinner";
import AdminHeaderLayout from "./admin/admin-header.layout";
import AdminFooterLayout from "./admin/admin-footer.layout";
import "./admin/admin.layout.scss";

const Dashboard = React.lazy(() => import("../pages/admin/dashboard/dashboard"));
const PermissionDenied = React.lazy(() => import("../pages/error/permission-denied"));
const NotFound = React.lazy(() => import("../pages/error/not-found"));

export default class AdminLayout extends Component {
  render() {
    const baseUrl = this.props.match.url;
    return (
      <div className="full-container">
        <AdminHeaderLayout />
        <div className="container">
          <BrowserRouter>
            <React.Suspense fallback={<Spinner />}>
              <Switch>
                <Route exact path="/admin">
                  <Redirect to={`${baseUrl}/dashboard`} />
                </Route>
                <Route path={`${baseUrl}/dashboard`} render={(props) => <Dashboard {...props} />} />
                <Route path="/denied" render={(props) => <PermissionDenied {...props} />} />
                <Route render={(props) => <NotFound {...props} />} />
              </Switch>
            </React.Suspense>
          </BrowserRouter>
        </div>
        <AdminFooterLayout />
      </div>
    );
  }
}
