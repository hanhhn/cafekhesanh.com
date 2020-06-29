import React, { Component } from "react";
import "./product.scss";

export default class Product extends Component {
  render() {
    return (
      <section>
        <a href="">
          <img
            src="https://images.ctfassets.net/vcddf3kukyq9/2aMGtYKdiEzCHDgxDSijpb/539bc36eca9dd78a84e841779d9119a3/_New--Hair-Removal-Ecomm__1_.jpg"
            style={{ width: "200px", height: "250px" }}
          />
          <h3>Product header</h3>
          <p>Quality shaving supplies + easy-to-use wax for convenience and comfort. </p>
        </a>
      </section>
    );
  }
}
