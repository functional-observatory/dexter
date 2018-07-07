import React from "react";
import { Link } from "react-router"; //eslint-disable-line
import styled from "styled-components";
import PropTypes from "prop-types";

const GradientButtonStyles = styled.div`
  font-size: 16px;
  padding: 10px 30px;
  margin-top: 20px;
  font-weight: 100;
  text-transform: uppercase;
  letter-spacing: 1px;
  background: linear-gradient(to right, #4facfe, #00f2fe);
  color: #fff;
  cursor: pointer;
  box-shadow: 0 8px 16px 0 rgba(46, 61, 73, 0.16);
  &:hover {
    box-shadow: none;
  }
`;

const GradientButton = ({ text, clicker }) => (
  <GradientButtonStyles onClick={() => clicker()}>{text}</GradientButtonStyles>
);

GradientButton.propTypes = {
  text: PropTypes.string.isRequired,
  clicker: PropTypes.func.isRequired
};

export default GradientButton;
