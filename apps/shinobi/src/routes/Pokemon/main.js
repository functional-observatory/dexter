import React from 'react';
import PropTypes from 'prop-types';
import { Flex } from '@elementary/components';

import Card from '../../components/card';

const Home = ({ pokemon }) => (
  <Flex
    style={{ flex: 1 }}
    w="100%"
    h="100%"
    direction="row"
    justifyContent="center"
    alignItems="center"
  >
    {pokemon.length && pokemon.map(x => <Card stats={x} />)}
  </Flex>
);

/* eslint-disable */
Home.propTypes = {
  pokemon: PropTypes.object.isRequired,
};

export default Home;
