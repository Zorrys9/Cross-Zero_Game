var hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/GameUsers")
    .build();

var count = 1;
var user = $('#figureUser').val();
var enemy = $('#figureEnemy').val();
var win = 0;
var lose = 1;

hubConnection.on("Move", function (position) {

    $('#' + position).addClass(enemy);

    checkResult(enemy, position);

    $('#move').val("user");

    Move();
});

$('.gameCell').click(function () {

    var id = this.id;

    $('#' + id).addClass(user);

    hubConnection.invoke("Move",  id.toString(), $('#enemy').html().trim() );

    checkResult(user, id);

    $('#move').val("enemy");

    Move();
});

function checkResult(type, id) {

    var cells = $('.' + type);
    var currentId = parseInt(id);

    if (cells.length > 2) {

        CheckRightGorizontCell(currentId, type);
        CheckLeftGorizontCell(currentId, type);

        CheckCount(type);

        CheckBottomVerticalCell(currentId, type);
        CheckTopVerticalCell(currentId, type);

        CheckCount(type);

        CheckRightDiagonalTopCell(currentId, type);
        CheckLeftDiagonalBottomCell(currentId, type);

        CheckCount(type);

        CheckLeftDiagonalTopCell(currentId, type);
        CheckRightDiagonalBottomCell(currentId, type);

        CheckCount(type);

    }

}

hubConnection.on("EndGame", function (result) {

    alert(result);
    location.pathname = "/Account/UsersList";

});

function EndGame(resultText, result, resultTextEnemy) {

    var userOne = $('#user').html().trim();
    var userTwo = $('#enemy').html().trim();

    hubConnection.invoke("EndGame", userTwo, resultTextEnemy);

    $.ajax({
        type: "POST",
        url: "/EndGame",
        data: { UserNameOne: userOne, UserNameTwo: userTwo, Result: result },
        success: function () {

           
            alert(resultText);
            location.pathname = "/Account/UsersList";

        },
        error: function () {

            alert("An error occurred when saving game datas");

        }

    });

}





function CheckCount(type) {


    if (count == 3 && $('#figureUser').val() == type ) {

        EndGame("Congratulations! You won!", win, "You lost...");
        count = 1;

    }
    else {

        count = 1;

    }

}

function CheckRightGorizontCell(id, type) {

    id++;

    if ($('#' + id).hasClass(type)) {

        count++;
        CheckRightGorizontCell(id, type);

    }
}

function CheckLeftGorizontCell(id, type) {

    id--;

    if ($('#' + id).hasClass(type)) {

        count++;
        CheckLeftGorizontCell(id, type);

    }
}

function CheckTopVerticalCell(id, type) {

    id += 10;

    if ($('#' + id).hasClass(type)) {

        count++;
        CheckTopVerticalCell(id, type);

    }

}

function CheckBottomVerticalCell(id, type) {

    id -= 10;

    if ($('#' + id).hasClass(type)) {

        count++;
        CheckBottomVerticalCell(id, type);

    }
}

function CheckLeftDiagonalBottomCell(id, type) {

    id += 11;

    if ($('#' + id).hasClass(type)) {

        count++;
        CheckLeftDiagonalBottomCell(id, type);

    }
}

function CheckRightDiagonalTopCell(id, type) {

    id -= 11;

    if ($('#' + id).hasClass(type)) {

        count++;
        CheckRightDiagonalTopCell(id, type);

    }
}

function CheckRightDiagonalBottomCell(id, type) {

    id += 9;

    if ($('#' + id).hasClass(type)) {

        count++;
        CheckRightDiagonalBottomCell(id, type);

    }
}

function CheckLeftDiagonalTopCell(id, type) {

    id -= 9;

    if ($('#' + id).hasClass(type)) {

        count++;
        CheckLeftDiagonalTopCell(id, type);

    }
}


function Move() {

    var cells = $('.gameCell');

    if ($('#move').val() == 'user') {

        $('#moveUser').html("You move : ");

        for (var i = 0; i < cells.length; i++) {

            cells[i].classList.remove('cellDisabled');

        }

    }
    else {

        $('#moveUser').html("Enemy move : ");

        for (var i = 0; i < cells.length; i++) {

            cells[i].classList.add('cellDisabled');

        }


    }

    $('#my_timer').html("01:00");
    startTimer();

}

function startTimer() {
    var my_timer = document.getElementById("my_timer");
    var time = my_timer.innerHTML;
    var arr = time.split(":");
    var m = arr[0];
    var s = arr[1];
    if (s == 0) {
        if (m == 0) {
            if ($('#move').val() == "user") {

                EndGame("Time's up... You lost", lose, "Congratulations! You won!");
                

            }
            else {

                EndGame("Congratulations! You won!", win, "Time's up... You lost");
                

            }


            m = 60;
        }
        m--;
        if (m < 10) m = "0" + m;
        s = 59;
    }
    else s--;
    if (s < 10) s = "0" + s;
    document.getElementById("my_timer").innerHTML = m + ":" + s;
    setTimeout(startTimer, 1000);
}

hubConnection.start();