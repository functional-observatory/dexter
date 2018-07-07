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
    >
      <Text fontWeight="bolder">Greninja</Text>
    </Flex>
  </Flex>
);

export default Card;
