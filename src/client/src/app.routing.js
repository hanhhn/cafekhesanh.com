import * as React from "react";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import { Spinner } from "./layouts/spinner";

const DefaultLayout = React.lazy(() => import("./layouts/default.layout"));
const AdminLayout = React.lazy(() => import("./layouts/admin.layout"));

export default class Routing extends React.Component {
  render() {
    return (
      <BrowserRouter>
        <React.Suspense fallback={<Spinner />}>
          <Switch>
            <Route path="/" render={(props) => <DefaultLayout {...props} />} />
            <Route path="/admin" render={(props) => <AdminLayout {...props} />} />
          </Switch>
        </React.Suspense>
      </BrowserRouter>
    );
  }
}
