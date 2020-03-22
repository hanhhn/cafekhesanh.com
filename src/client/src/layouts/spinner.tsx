import * as React from "react";
import { showSpinner, hideSpinner } from "../../src/cores/helpers/utils";

export class Spinner extends React.Component {
  componentWillMount() {
    showSpinner();
  }

  componentWillUnmount() {
    hideSpinner();
  }

  render() {
    return <div className="spinner hidden" />;
  }
}
