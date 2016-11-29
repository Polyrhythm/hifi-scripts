(function() {
    var SOUND_URL = 'https://github.com/Polyrhythm/hifi-scripts/raw/master/sounds/lol.wav';

    var hum = SoundCache.getSound(SOUND_URL);
    var injector = Audio.playSound(hum, {
        loop: true,
        position: this.position,
        stereo: true,
        volume: 0.25,
    });
})