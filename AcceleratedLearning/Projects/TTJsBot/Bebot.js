const tmi = require('tmi.js');

const options = {

options: {
debug: true,
},
connection: {
	cluster: 'aws',
	reconnect: true,
},
identity: {
	username: 'Beboliciousbot',
	password: 'oauth:xuymzrd65up20rk0idx810qmidkaxc',
},
channels: ['a1bebo'],

}

const client = new tmi.client(options);

client.connect();

client.on('connected', (adress, port) => {
	client.action('a1bebo', 'Hello, Beboliciousbot is now connected');

});

client.on('chat', (channel, user, message, self) => {
if (message === '!game'){
	client.action('a1bebo', 'a1bebo is currently not playing anything');
}
else if (message === '!about'){

    client.action('a1bebo', 'This bot is coded by a1bebo using the tmi.js and node.js libraries. Feel free to whisper a1bebo on twitch if you have any questions.')
}
else if (message === 'fan')
{
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	client.action('a1bebo', ' sluta svära!!!')
	
}

})
