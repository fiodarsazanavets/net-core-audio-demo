var player = require('play-sound')(opts = { });

exports.play = function (callback, fileName) {
	player.play(fileName, function (err) {
		if (err) callback(null, err.toString());
		callback(null, "Playback finished");
    });
}