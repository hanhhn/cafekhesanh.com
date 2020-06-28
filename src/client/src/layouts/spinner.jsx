import * as React from "react";
// import { showSpinner, hideSpinner } from "../cores/helpers/utils";

export class Spinner extends React.Component {
  // UNSAFE_componentWillMount () {
  //   showSpinner();
  // }

  // UNSAFE_componentDidMount() {
  //   hideSpinner();
  // }

  render() {
    return <div className="spinner hidden" />;
  }
}
