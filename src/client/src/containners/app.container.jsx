import React, { Component } from "react";
import { connect } from "react-redux";
import Routing from "../app.routing";

class AppContainer extends Component {
  render() {
    return <Routing />;
  }
}

export default connect(
  (state) => {
    return {
      auth: state.authReducer,
    };
  },
  (dispatch) => {
    return {};
  }
)(AppContainer);
