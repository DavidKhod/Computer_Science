function validateAll() {

    var result = true;

    result = userNameVal() && result;
    result = passwordVal() && result;
    result = userFirstNameVal() && result;
    result = userSecondNAmeVal() && result;
    result = confirmPassFun() && result;

    return result;

}



// validating username

function userNameVal() {
    var userName = document.getElementById("UserName").value;
    if (userName == "") {
        document.getElementById("messUserName").value = "User Name is Required";
        document.getElementById("messUserName").style.display = "inline";
        return false;

    }
    return true;
}

// validating firstname

function userFirstNameVal() {
    var userFirstName = document.getElementById("FirstName").value;
    if (userFirstName == "") {
        document.getElementById("messFirstName").value = "First Name is Required";
        document.getElementById("messFirstName").style.display = "inline";
        return false;
    }


    return true;
}

// validating lastname

function userSecondNAmeVal() {
    var userSecondName = document.getElementById("SecondName").value;
    if (userSecondName == "") {
        document.getElementById("messSecondName").value = "Last Name is Required";
        document.getElementById("messSecondName").style.display = "inline";
        return false;
    }
    return true;
}

// validating password

function passwordVal() {
    var pass = document.getElementById("Password").value;
    if (pass.length < 3) {
        document.getElementById("messPassword").value = "password must contain at least 3 charactes";
        document.getElementById("messPassword").style.display = "inline";
        return false;
    }
    return true;
}

// validating password confirmation

function confirmPassFun() {
    var pass = document.getElementById("Password").value;
    var confirm = document.getElementById("ConfPassword").value;
    if (pass != confirm) {
        document.getElementById("messConfPassword").value = "passwords doesn't match";
        document.getElementById("messConfPassword").style.display = "inline";
        return false;
    }

    return true;
}

// validating email

function confirmEmail() {

    var email = document.getElementById("Email").value;
    var reg = /^\w+/;
    if (!reg.test(email)) {
        document.getElementById("messEmail").value = "mail must start with letter or digit ";
        document.getElementById("messEmail").style.display = "inline";
        return false;
    }

    reg = /^\w+([\.-]?\w+)/;
    if (!reg.test(email)) {
        document.getElementById("messEmail").value = "mail can have only one [. or -] following letter ";
        document.getElementById("messEmail").style.display = "inline";
        return false;
    }

    reg = /^\w+([\.-]?\w+)*@/;
    if (!reg.test(email)) {
        document.getElementById("messEmail").value = "mail must have @ "
        document.getElementById("messEmail").style.display = "inline";
        return false;
    }

    reg = /^\w+([\.-]?\w+)*@\w+/;
    if (!reg.test(email)) {
        document.getElementById("messEmail").value = "you need letters after@ "
        document.getElementById("messEmail").style.display = "inline";
        return false;
    }


    reg = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/;
    if (!reg.test(email)) {
        document.getElementById("messEmail").value = "Invalid email "
        document.getElementById("messEmail").style.display = "inline";

        return false;
    }
    //----- IMPORTANT !!! --------
    if (validateAll()) {
        document.getElementById("submit").disabled = false;
    }
    return true;
}

   


