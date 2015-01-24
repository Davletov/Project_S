/*********************************************************************/
var player;
window.startYoutube = function () {
    player = new YT.Player('player', {
        height: '390',
        width: '640',
        videoId: 'M7lc1UVf-VE',
        events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
        }
    });
}

function onPlayerReady(event) {
    event.target.playVideo();
}
function onPlayerStateChange(event) {
}
function stopVideo() {
    player.stopVideo();
}
/*********************************************************************/
$('.thumbnail').click(function () {
    var mask = $('<a/>', { href: 'javascript:{}' });
    mask.addClass('mask');
    $('body').append(mask);
    var player = $('<div/>', { id: 'player' });
    $('body').append(player);

    window.startYoutube();

    function closeWindow() {
        if (confirm("Close?")) {
            this.remove();
            $('#player').remove();
        }
    }

    mask.click(closeWindow);
});