import React from 'react';
import PropTypes from 'prop-types';
import { Flex } from '@elementary/components';

import Card from '../../components/card';

const Home = ({ showNotifier }) => (
  <Flex
    style={{ flex: 1 }}
    w="100%"
    h="100%"
    direction="column"
    justifyContent="center"
    alignItems="center"
  >
    Cards here
    <Card bg="linear-gradient(120deg, #89f7fe 0%, #66a6ff 100%)" ig="#081d2e" />
  </Flex>
);

Home.propTypes = {
  showNotifier: PropTypes.func.isRequired,
};

export default Home;
