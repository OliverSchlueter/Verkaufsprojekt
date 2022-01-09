<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="../assets/css/vars.css">
    <link rel="stylesheet" href="../assets/css/style.css">
    <link rel="stylesheet" href="../assets/css/login.css">
    <title>Verkaufsprojekt - Login</title>
</head>
<body>

<?php

    if(isset($_POST['loginSubmit'])){

        require_once("../assets/php/hasher.php");
        require_once("../assets/php/classes/user.php");
        require_once("../assets/php/database.php");

        if(!$connectedToDatabase){
            echo "<script>window.alert('Ein Fehler mit der Datenbank ist unterlaufen, bitte laden Sie die Seite neu');</script>";
            die();
        }

        $id = $_POST['loginID'];
        $password = $_POST['loginPassword'];
        $hashedPassword = hashPassword($id, $password);

        $foundUser = false;
        foreach($db->query("SELECT * FROM benutzer WHERE benutzerID='$id'") as $row){
            if($row['passwort'] != $hashedPassword){
                echo "<script>window.alert('Falsches passwort');</script>";
                $foundUser = true;
                break;
            } else {

                $user = null;

                $foundCostomer = false;
                foreach($db->query("SELECT * FROM kunde WHERE benutzerID='$id'") as $cRow){
                    $foundCostomer = true;
                    $user = new Customer(
                        $row['benutzerID'], 
                        $row['vorname'], 
                        $row['nachname'], 
                        $row['nickname'], 
                        $row['email'], 
                        $row['geburtsdatum'], 
                        $row['erstelldatum'], 
                        $hashedPassword,
                        $cRow['guthaben']
                    );
                }

                $foundAutor = false;
                foreach($db->query("SELECT * FROM autor, entwicklerstatus WHERE benutzerID='$id' AND entwicklerstatus.entwicklerstatusID = autor.entwicklerstatus") as $aRow){
                    $foundCostomer = true;
                    $user = new Autor(
                        $row['benutzerID'], 
                        $row['vorname'], 
                        $row['nachname'], 
                        $row['nickname'], 
                        $row['email'], 
                        $row['geburtsdatum'], 
                        $row['erstelldatum'], 
                        $hashedPassword,
                        $aRow['beschreibung']
                    );
                }

                //TODO: add checks if user is Mitarbeiter, Autor...

                if(!$foundCostomer && !$foundAutor){
                    $user = new User(
                        $row['benutzerID'], 
                        $row['vorname'], 
                        $row['nachname'], 
                        $row['nickname'], 
                        $row['email'], 
                        $row['geburtsdatum'], 
                        $row['erstelldatum'], 
                        $hashedPassword
                    );
                }

                session_start();
                $_SESSION['user'] = $user;

                echo "<script>window.alert('Erfolgreich eingeloggt'); window.open('../', '_self')</script>";

                $foundUser = true;
                break;
            }
        }

        if(!$foundUser){
            echo "<script>window.alert('Falsche Benutzer ID');</script>";
        }

    }

    ?>


    <header>
        <?php 
            require_once("../assets/php/nav.php");
            $nav->getNav(false, "login");
        ?>
    </header>
    

    <main>
        <h1>Login Formular</h1>

        <form action="" method="post">
            <div class="inputFields">
                <div class="inputField" id="inputFieldID">
                    <label for="loginID">Benutzer ID:</label><br>
                    <input type="text" name="loginID" id="loginID" maxlength="5" minlength="5" placeholder="K5A7V">
                </div>
                <div class="inputField">
                    <label for="loginPassword">Passwort:</label><br>
                    <input type="password" name="loginPassword" id="loginPassword" minlength="8" placeholder="xxxxxxxxxxxxxx">
                </div>
            </div>

            <button type="submit" name="loginSubmit">Einloggen</button>
        </form>
    </main>

</body>
</html>