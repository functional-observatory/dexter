import React from 'react';
import { Flex, Image, Text } from '@elementary/components';

const Card = ({ bg, ig }) => (
  <Flex
    w="350px"
    borderRadius="15px"
    m="10px"
    h="500px"
    p="15px"
    direction="column"
    style={{ background: bg }}
    alignItems="center"
  >
    <Flex w="100%" h="200px" bg="rgba(0,0,0,0.8)">
      <Image
        src="https://pokeres.bastionbot.org/images/pokemon/658.png"
        style={{ objectFit: 'scale-down' }}
      />
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
              Greninja
            </Text>
            <Text className="italics">Ninja Pokemon</Text>
          </Flex>
          <Text>Water, Dark</Text>
        </Flex>
        <Flex pb="6px">
          <Text fontWeight="bolder">Height:</Text>
          <Text pl="2px">411</Text>
        </Flex>
        <Flex pb="6px">
          <Text fontWeight="bolder">Width:</Text>
          <Text pl="2px">411</Text>
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
              <Text pr="4px">Froakie</Text>
              <Text pr="4px">{' > '}</Text>
              <Text pr="4px">Frogadier</Text>
              <Text pr="4px">{' > '}</Text>
              <Text pr="4px">Greninja</Text>
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
            <Text pl="2px">Torrent</Text>
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
            <Text pl="2px">Protean</Text>
          </Flex>
        </Flex>
      </Flex>
    </Flex>
  </Flex>
);

export default Card;
