var hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/Call")
    .build();

hubConnection.on("Call", function (call) {

    $('#challengeH').append("You are called to battle by the <span id='challengeUser'> " + call.from + "</span>. your statistics with this user " + call.statistic);
    $('#ChallengeModal').modal("show");


});

hubConnection.on("Play", function (from) {

    location.pathname = "Game/" + currentUser + "/" + from;

});

hubConnection.on("Deny", function (from) {

    $('#responseH').append(from + "refused to play with you");
    $("#responseModal").modal("show");
    $('#WaitModal').modal('hide');

});

hubConnection.on("Cancel", function (from) {

    $("#ChallengeModal").modal('hide');

});

//hubConnection.on("Refresh", function () {

//    if (!$('#WaitModal').hasClass('show') && !$('#ChallengeModal').hasClass('show')) {

//        $.ajax({
//            type: "GET",
//            url: "UsersList",
//            success: function (page) {

//                document.body.innerHTML = page;

//            },
//            error: function (error) {

//                alert(error.responseText);

//            }

//        });

//    }

//});

$("#PlayBut").click(function () {

    var to = $("#challengeUser").html().trim();

    $.ajax({
        type: "POST",
        url: "/CreateGame",
        data: { UserNameOne: currentUser, UserNameTwo: to },
        success: function () {

            hubConnection.invoke("Play", { to: to, from: currentUser });
            location.pathname = "Game/" + currentUser + "/" + to;

        },
        error: function () {

            hubConnection.invoke("Deny", { to: to, from: currentUser });
            hubConnection.invoke("Refresh");
            alert('при создании игры возникла ошибка');
            $("#ChallengeModal").modal('hide');

        }
    });
})

$('#DenyBut').click(function () {

    $('#ChallengeModal').modal('hide');

    var to = $('#challengeUser').html().trim();

    hubConnection.invoke("Deny", { to: to, from: currentUser });
    hubConnection.invoke("Refresh");

});

$(document.body).on("click", '#CancelBut', function () {

    var waitingUser = $('#waitingUser').val();

    hubConnection.invoke("Cancel", { to: waitingUser, from: currentUser });
    hubConnection.invoke("Refresh");

    $("#WaitModal").modal('hide');

});

$('.play').click(function () {

    var user = $("#username" + this.id).html();
    var statistic = $("#statistic" + this.id).html();

    hubConnection.invoke("Call", { to: user, from: currentUser, statistic: statistic });
    hubConnection.invoke("Refresh");

    $('#WaitModal').modal('show');
    $('#waitingUser').val(user);

})

hubConnection.start();