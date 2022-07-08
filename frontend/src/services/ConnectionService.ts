export function getOrigin() : string{
  return `${determineHost()}:${determinePort()}`;
}

/**
 * Figure out which host to use to connect to the Stanza service.
 */
function determineHost() : string {
  return window.location.protocol + "//" + window.location.hostname
}

/**
 * Figure out which port to use to connect to the Stanza service.
 */
function determinePort() : string {
  const port = window.location.port;
  return port;
}