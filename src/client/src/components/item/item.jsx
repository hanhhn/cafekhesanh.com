import React, { Component } from "react";
import "./item.scss";

export default class Item extends Component {
  render() {
    return (
      <section className="prod">
        <a className="summary" href=".">
          <div className="image">
            <label className="badge">
              <span>New</span>
            </label>
            <picture>
              <img
                src="https://images.ctfassets.net/vcddf3kukyq9/2aMGtYKdiEzCHDgxDSijpb/539bc36eca9dd78a84e841779d9119a3/_New--Hair-Removal-Ecomm__1_.jpg"
                alt=""
              />
            </picture>
          </div>
          <div className="information">
            <h3 className="name">Product header</h3>
            <p className="description">Product description</p>
            <p className="price">100.000 đ</p>
          </div>
        </a>
        <ul className="thumb">
          <li>1</li>
          <li>2</li>
          <li>3</li>
          <li>3</li>
        </ul>
      </section>
    );
  }
}
