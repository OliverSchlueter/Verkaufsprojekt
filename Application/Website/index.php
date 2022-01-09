<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="assets/css/vars.css">
    <link rel="stylesheet" href="assets/css/style.css">
    <title>Verkaufsprojekt - Startseite</title>
</head>
<body>
    <header>
        <?php 
            require_once("assets/php/nav.php");
            $nav->getNav(true, "#");
        ?>
    </header>
    
    <main>
        <h1 id="headline">Willkommen zur offiziellen <span class="aqua">Verkaufsprojekt</span> Website</h1>
    </main>

</body>
</html>