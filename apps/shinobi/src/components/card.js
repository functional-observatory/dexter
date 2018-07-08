import React from 'react';
import PropTypes from 'prop-types';
import { Flex, Image, Text } from '@elementary/components';
import typeArray from '../utils/typearray';

const Card = ({ stats }) => (
  <Flex
    w="350px"
    borderRadius="15px"
    mr="10px"
    mt="10px"
    h="500px"
    p="15px"
    direction="column"
    style={{ background: typeArray[stats.types.last()] }}
    alignItems="center"
  >
    <Flex w="100%" h="200px" bg="rgba(0,0,0,0.8)">
      <Image src={stats.sprite} style={{ objectFit: 'scale-down' }} />
    </Flex>
    <Flex
      style={{ flex: 2 }}
      p="10px"
      bg="rgba(255, 255, 255, 0.5)"
      w="100%"
      color={({ theme }) => theme.colors.bg}
      direction="column"
      justifyContent="space-between"
    >
      <Flex direction="column">
        <Flex justifyContent="space-between" alignItems="center" pb="6px">
          <Flex direction="column">
            <Text fontWeight="bolder" f="20px">
              {stats.name}
            </Text>
            <Text className="italics">{stats.species} Pokemon</Text>
          </Flex>
          <Text>{stats.types.join(', ')}</Text>
        </Flex>
        <Flex pb="6px">
          <Text fontWeight="bolder">Height:</Text>
          <Text pl="2px">{stats.height}</Text>
        </Flex>
        <Flex pb="6px">
          <Text fontWeight="bolder">Width:</Text>
          <Text pl="2px">{stats.weight}</Text>
        </Flex>
      </Flex>
      <Flex direction="column">
        <Flex justifyContent="space-between" alignItems="center" pb="10px">
          <Flex direction="column">
            <Text
              f="12px"
              textTransform="uppercase"
              fontWeight="bolder"
              letterSpacing="1px"
            >
              Evolution
            </Text>
            <Flex>
              {stats.family.evolutionLine
                .join(',>,')
                .split(',')
                .map(x => <Text pr="4px">{x}</Text>)}
            </Flex>
          </Flex>
        </Flex>
        <Flex justifyContent="space-between" alignItems="center" pb="10px">
          <Flex direction="column">
            <Text
              f="12px"
              textTransform="uppercase"
              fontWeight="bolder"
              letterSpacing="1px"
            >
              Ability
            </Text>
            <Text pl="2px">{stats.abilities.normal.first()}</Text>
          </Flex>
          <Flex direction="column">
            <Text
              f="12px"
              textTransform="uppercase"
              fontWeight="bolder"
              letterSpacing="1px"
            >
              Hidden Ability
            </Text>
            <Text pl="2px">{stats.abilities.hidden.first()}</Text>
          </Flex>
        </Flex>
      </Flex>
    </Flex>
  </Flex>
);

//
Card.propTypes = {
  stats: PropTypes.object.isRequired,
};

export default Card;
