<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="../assets/css/vars.css">
    <link rel="stylesheet" href="../assets/css/style.css">
    <link rel="stylesheet" href="../assets/css/login.css">
    <link rel="stylesheet" href="../assets/css/register.css">
    <title>Verkaufsprojekt - Registierung</title>
</head>
<body>

<?php

    if(isset($_POST['registerSubmit'])){

        require_once("../assets/php/hasher.php");
        require_once("../assets/php/classes/user.php");
        require_once("../assets/php/database.php");

        if(!$connectedToDatabase){
            echo "<script>window.alert('Ein Fehler mit der Datenbank ist unterlaufen, bitte laden Sie die Seite neu');</script>";
            die();
        }

        $firstName = $_POST['registerFirstName'];
        $lastName = $_POST['registerLastName'];
        $nickname = $_POST['registerNickname'];
        $email = $_POST['registerEmail'];
        $birthday = $_POST['registerBirthday'];
        $password = $_POST['registerPassword'];
        $id = getNewUserID($db);
        $hashedPassword = hashPassword($id, $password);
        $creationDate = date("Y-m-d");
    
        $db->query("INSERT INTO benutzer VALUES('$id','$firstName','$lastName','$nickname','$email','$birthday','$creationDate','$hashedPassword')");
        $db->query("INSERT INTO kunde VALUES('$id', 0)");
    
        $user = new Customer($id, $firstName, $lastName, $nickname, $email, $birthday, $creationDate, $hashedPassword, 0);
        session_start();
        $_SESSION["user"] = $user;

        echo "<script>window.alert('Erfolgreich registiert. Ihre Benutzer ID ist: $id Bitte merken sie sich diese, sie wird bei der Anmeldung benötigt.'); window.open('../', '_self'); </script>";
    }

    ?>


    <header>
        <?php 
            require_once("../assets/php/nav.php");
            $nav->getNav(false, "register");
        ?>
    </header>
    

    <main>
        <h1>Registierungs Formular</h1>

        <form action="" method="post">
            <div class="inputFields">
                <div class="inputField">
                    <label for="registerFirstName">Vorname:</label><br>
                    <input type="text" name="registerFirstName" id="registerFirstName" placeholder="Oliver" required>
                </div>
                <div class="inputField">
                    <label for="registerLastName">Vorname:</label><br>
                    <input type="text" name="registerLastName" id="registerLastName" placeholder="Schlüter" required>
                </div>
                <div class="inputField">
                    <label for="registerNickname">Nickname:</label><br>
                    <input type="text" name="registerNickname" id="registerNickname" placeholder="Oliver1337" required>
                </div>
                <div class="inputField">
                    <label for="registerEmail">Email Adresse:</label><br>
                    <input type="text" name="registerEmail" id="registerEmail" placeholder="Oliver@gmail.com" required>
                </div>
                <div class="inputField">
                    <label for="registerBirthday">Geburtsdatum:</label><br>
                    <input type="date" name="registerBirthday" id="registerBirthday" required>
                </div>
                <div class="inputField">
                    <label for="registerPassword">Passwort:</label><br>
                    <input type="password" name="registerPassword" id="registerPassword" minlength="8" placeholder="Nicht 'passwort'" required>
                </div>
            </div>

            <button type="submit" name="registerSubmit">Registieren</button>
        </form>
    </main>

</body>
</html>