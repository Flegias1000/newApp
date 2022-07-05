function ajaxRandomNumber() {
    var url = "/api/API/GetValue";
    $.ajax({
        method: "GET",
        url: url,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data, status) {
            console.log(data);
            $("#resultValue").append("<br/><div>numero generato da 1 a 20 : <span class='h2'>" + data + "</span></div>");
            this.always();
        },
        error: function (error, status) {
            console.log(error);
            console.log(status);
            this.always();
        },
        always: function () { }
    });
};

function ajaxInvertiStringa() {
    let variabile = document.getElementById("stringa").value;
    var splitString = variabile.split("");
    var reverseArray = splitString.reverse();
    var joinArray = reverseArray.join("");
    document.getElementById("resultStringa").innerHTML = "<h2><center>"+joinArray;

};

function ajaxInserisci() {
    
    let nome = document.getElementById("txtNome").value;
    let cognome = document.getElementById("txtCognome").value;
    let data = { nome: nome, cognome: cognome };

    var url = "/api/Persons/Insert";
    $.ajax({
        method: "POST",
        url: url,
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(data),
        dataType: "json",
        success: function (data, status) {
            console.log(data);
            this.always();
        },
        error: function (error, status) {
            console.log(error);
            console.log(status);
            this.always();
        },
        always: function () { }
    });
}
