(function youtube() {
    var player;
    window.startYoutube = function(id) {
        player = new YT.Player('player', {
            height: '390',
            width: '640',
            videoId: id,
            events: {
                'onReady': onPlayerReady,
                'onStateChange': onPlayerStateChange
            }
        });
    };

    function onPlayerReady(event) {
        event.target.playVideo();
    }

    function onPlayerStateChange(event) {
    }

    function stopVideo() {
        player.stopVideo();
    }

    /*********************************************************************/
    $('.thumbnail[data-type="Youtube"]').click(function () {
        var videoId = $(this).data('videoId');
        var mask = $('<a/>', { href: 'javascript:{}' });
        mask.addClass('mask');
        $('body').append(mask);
        var player = $('<div/>', { id: 'player' });
        $('body').append(player);

        window.startYoutube(videoId);

        function closeWindow() {
            if (confirm("Close?")) {
                this.remove();
                $('#player').remove();
            }
        }

        mask.click(closeWindow);
    });
})();