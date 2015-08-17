$(function () {
    $("#refresh").click(function () {
        $.ajax({
            type: "GET",
            url: "/home/background",
            data: {
                race: $("#raceSelector option:selected").text()
            },
            success: function (d) {
                $("#CharInfoContainer").html(d);
            },
            error: function () {
                console.log("An error occurred during refresh");
            },
            complete: function () {

            }
        })
    });
})