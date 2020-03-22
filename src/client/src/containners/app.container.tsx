import React, { Component } from "react";
import { connect } from "react-redux";
import Routing from "../app.routing";

class AppContainer extends Component<any> {
  render() {
    return <Routing />;
  }
}

export default connect(
  (state: any) => {
    return {
      auth: state.authReducer
    };
  },
  (dispatch: any) => {
    return {};
  }
)(AppContainer);
