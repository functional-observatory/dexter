import React from 'react';
import { IndexLink, Link } from 'react-router'; // eslint-disable-line
import { Flex } from '@elementary/components';
import PropTypes from 'prop-types';
import Notifier from '../connectors/notifier';

export const CoreLayout = ({ children }) => (
  <Flex w="100%" h="100%" direction="column">
    <Flex
      alignItems="center"
      justifyContent="center"
      h="60px"
      style={{
        background: 'linear-gradient(135deg, #667eea 0%, #764ba2 100%)',
      }}
    >
      {"Rajat's Pokedex"}
    </Flex>
    <Notifier />
    <Flex
      style={{ flex: 1 }}
      w="100%"
      h="100%"
      direction="column"
      justifyContent="center"
      alignItems="center"
    >
      {children}
    </Flex>
  </Flex>
);

CoreLayout.propTypes = {
  children: PropTypes.node.isRequired,
};

export default CoreLayout;
