import React from 'react';
import PropTypes from 'prop-types';
import { Flex, Text, Input } from '@elementary/components';
import Card from '../../components/card';

const Home = ({ recents, searchPokemon, changeSearchText, searchText }) => (
  <Flex
    style={{ flex: 1 }}
    w="1050px"
    h="100%"
    direction="column"
    justifyContent="center"
    flexWrap="wrap"
  >
    <Flex w="100%" pb="40px">
      <form submit={() => searchPokemon(searchText)}>
        <Input
          placeholder="Search For Pokemons"
          w="500px"
          p="0"
          value={searchText}
          onChange={e => changeSearchText(e.target.value)}
          boxShadow="none !important"
          style={{ fontSize: '40px', fontWeight: 'bolder' }}
          fontWeight="bolder"
          focus={{ boxShadow: 'none !important' }}
        />
      </form>
    </Flex>
    <Text textTransform="uppercase" fontWeight="bolder" letterSpacing="2px">
      Recent Sightings
    </Text>
    <Flex>{recents.map(x => <Card stats={x} />)}</Flex>
  </Flex>
);

/* eslint-disable */
Home.propTypes = {
  searchPokemon: PropTypes.func,
  changeSearchText: PropTypes.func,
  searchText: PropTypes.string,
  recents: PropTypes.object.isRequired,
};

export default Home;
