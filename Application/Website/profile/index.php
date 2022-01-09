<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="../assets/css/vars.css">
    <link rel="stylesheet" href="../assets/css/style.css">
    <link rel="stylesheet" href="../assets/css/profile.css">
    <title>Verkaufsprojekt - Produkte</title>
</head>
<body>
    <header>
        <?php
            require_once("../assets/php/classes/product.php");
            require_once("../assets/php/classes/user.php");
            require_once("../assets/php/database.php");
            require_once("../assets/php/nav.php");
            $nav->getNav(false, "profile");

            $user = $_SESSION['user'];

            if(isset($_POST['logoutSubmit'])){
                if(isset($_SESSION['user'])){
                    unset($_SESSION["user"]);
                    ?>
                        <script>
                        window.alert("Erfolgreich ausgeloggt.");
                        window.open("../", "_self");
                        </script>
                    <?php
                }
            }

        ?>
    </header>

    <main>
        <form action="" method="post">
            <button id="logoutBtn" name="logoutSubmit" type="submit">Logout</button>
        </form>

        <?php
            // cards

            include("cards/profile.php");

            if($user instanceof Customer){
                include("cards/boughtProducts.php");
            }

            if($user instanceof Autor){
                include("cards/writtenProducts.php");
                include("cards/createProduct.php");
            }
        ?>
    </main>
    
</body>
</html>