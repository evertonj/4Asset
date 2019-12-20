const PROXY_CONFIG = [
    {
        context:['/api'],
        target: 'https://localhost:44372/',
        secure: true,
        loglevel: 'debug'
    }
];

module.exports = PROXY_CONFIG;