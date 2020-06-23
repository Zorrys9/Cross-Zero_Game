var hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/GameUsers")
    .build();

var count = 1;
var user = $('#figureUser').val();
var enemy = $('#figureEnemy').val();

hubConnection.on("Move", function (position) {

    $('#' + position).addClass(enemy);

    checkResult(enemy, position);
});

$('.gameCell').click(function () {

    var id = this.id;

    $('#' + id).addClass(user);

    hubConnection.invoke("Move",  id.toString(), $('#enemy').html().trim() );

    checkResult(user, id);
});

function checkResult(type, id) {

    var cells = $('.' + type);
    var currentId = parseInt(id);

    if (cells.length > 2) {

        CheckRightGorizontCell(currentId, type);
        CheckLeftGorizontCell(currentId, type);

        CheckCount();

        CheckBottomVerticalCell(currentId, type);
        CheckTopVerticalCell(currentId, type);

        CheckCount();

        CheckRightDiagonalTopCell(currentId, type);
        CheckLeftDiagonalBottomCell(currentId, type);

        CheckCount();

        CheckLeftDiagonalTopCell(currentId, type);
        CheckRightDiagonalBottomCell(currentId, type);

        CheckCount();

    }

}

hubConnection.start();

function CheckCount() {

    if (count == 3) {

        alert("Congratulations! You won!");
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