import * as React from "react";
import { showSpinner, hideSpinner } from "../cores/helpers/utils";

export class Spinner extends React.Component {
  constructor(props) {
    super(props);
    showSpinner();
  }

  componentWillUnmount() {
    hideSpinner();
  }

  render() {
    return <div />;
  }
}
