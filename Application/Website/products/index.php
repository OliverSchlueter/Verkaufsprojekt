<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="../assets/css/vars.css">
    <link rel="stylesheet" href="../assets/css/style.css">
    <link rel="stylesheet" href="../assets/css/products.css">
    <script src="../assets/js/dialogManager.js"></script>
    <script src="../assets/js/searchProduct.js"></script>
    <title>Verkaufsprojekt - Produkte</title>
</head>
<body>
    <header>
        <?php 
            require_once("../assets/php/classes/product.php");
            require_once("../assets/php/classes/user.php");
            require_once("../assets/php/database.php");
            require_once("../assets/php/nav.php");
            $nav->getNav(false, "products");

            if(!$connectedToDatabase){
                echo "<script>window.alert('Ein Fehler mit der Datenbank ist unterlaufen, bitte laden Sie die Seite neu');</script>";
                die();
            }
        ?>
    </header>

    <main>

    <div class="dialog-container" id="dialogView">
        <dialog id="viewDialog" open>
            <!-- <button class="hideBtn" onclick="hideDialog()">X</button> -->
            <img id="hideBtn" onclick="hideDialog()" src="https://upload.wikimedia.org/wikipedia/commons/a/a0/OOjs_UI_icon_close.svg" alt="X" width="50px" height="50px">
            <p id="name">Produkt</p>
            <div id="information">
                <p id="id">#####</p>
                <p id="releaseDate">YYYY-MM-DD</p>
                <p id="price">xx.xx €</p>
            </div>
            <div id="autors">
                <p id="autoren">Autoren:</p>
            </div>

            <div class="descriptonContainer">
                <p id="description">
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Soluta voluptatibus illum doloribus, aspernatur recusandae ullam. Provident, fuga dolorum. Et, repudiandae facere provident voluptatem quas quibusdam! Omnis nam ad fuga dolor!
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Ab aspernatur eos, libero necessitatibus repellat facere atque nobis explicabo tempora error aut porro ipsam nihil esse voluptatum nostrum consequuntur. Unde, laboriosam?
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Alias quisquam eaque quam explicabo in ipsam, aperiam delectus sit cum excepturi magni consectetur dolorem officiis reiciendis sequi iure repellendus. Ullam, cumque.
                    Lorem ipsum dolor, sit amet consectetur adipisicing elit. Rerum soluta repellendus atque porro laboriosam consectetur, voluptatem reprehenderit nesciunt dolor placeat veritatis, corporis architecto facere ad? Facilis ducimus dolor voluptas vitae.
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Earum sequi laudantium dolore ea eos illum. Aspernatur odio ab placeat id, autem omnis animi est perspiciatis excepturi, iste nisi fugit repellendus!
                    Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime ad quasi velit. Rerum asperiores sint temporibus adipisci veritatis, mollitia quod molestiae repellendus? Facere, quibusdam? Libero, totam. Suscipit nobis illo ducimus.
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Labore hic expedita et animi id alias quisquam voluptates numquam sapiente quam, omnis totam obcaecati aliquam ipsum ad aspernatur distinctio impedit? Soluta.
                    Lorem ipsum dolor sit amet consectetur, adipisicing elit. Eaque ipsa rem repellendus. Repellendus optio adipisci fugit deleniti officiis placeat similique atque delectus necessitatibus! Maiores nesciunt inventore distinctio molestias magni ipsam!
                    Lorem, ipsum dolor sit amet consectetur adipisicing elit. Suscipit deleniti reprehenderit sequi dicta laudantium delectus modi doloribus adipisci? Dolorum amet unde quis placeat porro odio labore magnam! Commodi, amet doloremque.
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Tempora rerum nesciunt deserunt illo quibusdam quas, delectus laboriosam ad debitis aspernatur asperiores molestias culpa animi rem non id doloremque perferendis iusto.
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Eum deserunt tenetur consequatur repudiandae accusamus, magni iure odio recusandae debitis necessitatibus vitae iusto adipisci et velit quasi doloribus fugiat nisi eligendi!
                    Lorem ipsum, dolor sit amet consectetur adipisicing elit. Sequi fuga labore modi, at itaque incidunt repellat doloremque quaerat quidem accusamus recusandae eum esse tempora doloribus necessitatibus numquam inventore facere ad.
                    Lorem, ipsum dolor sit amet consectetur adipisicing elit. Harum, laboriosam obcaecati! Deserunt eveniet voluptatem repellat blanditiis! Ratione ipsum veritatis corporis est delectus possimus magni aperiam. Rerum voluptates cupiditate nostrum accusamus?
                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Temporibus porro quo cumque, unde rem magni eos optio recusandae sequi, numquam totam vel harum ducimus hic reiciendis, nulla fugiat voluptas ad.
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam incidunt voluptatibus perferendis! Neque assumenda distinctio, beatae magnam perferendis ex nemo enim totam, non hic mollitia ducimus officiis. Numquam, nulla ipsa?
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. In laudantium, eum facilis aspernatur, laboriosam quaerat ab at vitae cum tempore error maiores quasi dolores. Sapiente, totam odio. Necessitatibus, ullam alias?
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus consectetur porro exercitationem iure laboriosam saepe, doloribus commodi ullam ipsa repellat deleniti nesciunt unde quod autem voluptatum, veniam eius vel dolorum.
                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Esse soluta eveniet architecto dignissimos! Totam dignissimos ea laudantium est vitae voluptate omnis! Accusantium repellendus neque deleniti sint. Molestias omnis ipsum sunt.
                </p>
            </div>
            <form action="" method="post">
                <button type="submit" name="buySubmit" class="buyBtn buy">Kaufen</button>
                <button type="submit" name="observeSubmit" class="buyBtn observe">Beobachten</button>
                <button type="submit" name="wishSubmit" class="buyBtn wish">Wünschen</button>
                <input type="text" name="pID" id="pID" style="visibility: hidden;">
            </form>
        </dialog>
    </div>

        <h1 class="headline">Verfügbare Produkte</h1>
        <form action="" method="post" id="searchProductForm">
            <input type="text" name="searchProduct" id="searchProduct" placeholder="Suchen">
        </form>
        <div class="products">
        <?php
        $products = [];

        foreach($db->query("SELECT * FROM produkt ORDER BY veroeffentlichungsdatum DESC") as $row){
            $products[count($products)] = new Product(
                $row["produktID"],
                $row["name"],
                $row["preis"],
                $row["beschreibung"],
                $row["veroeffentlichungsdatum"]
            );
        }

        foreach($products as $p){
            
            $autors = "";
            foreach($db->query("SELECT * FROM autor_schreibt_produkt, benutzer WHERE produktID = '".$p->id."' AND benutzer.benutzerID = autor_schreibt_produkt.benutzerID") as $row){
                $autors .= $row['vorname'] . " " . $row['nachname'] . ",";
            }

            $autors = substr($autors, 0, -1);

            echo '
            <div class="product" id="product_'.$p->name.' '.$p->id.'">
                <p class="name">'.$p->name.'</p>
                <p class="id">'.$p->id.'</p>
                <p class="releaseDate">'.$p->releaseDate.'</p>
                <p class="price">'.$p->price.'€</p>
                <button class="viewBtn" onclick="showDialog(\''.$p->id.'\', \''.$p->name.'\', \''.$p->price.'\', \''.$p->description.'\', \''.$p->releaseDate.'\', \''.$autors.'\')">Anzeigen</button>
            </div>';

        }

        ?>

        </div>

        <?php
        // Produkt kaufen

        if(isset($_POST["buySubmit"])){
            $pid = $_POST['pID'];

            if(!isset($_SESSION['user'])){
                echo "<script> window.alert('Sie sind nicht eingeloggt'); window.open('../login/', '_self'); </script>";
                die();
            }
            
            $user = $_SESSION['user'];
            
            if(!($user instanceof Customer)){
                echo "<script> window.alert('Sie sind nicht als Kunde eingeloggt'); </script>";
                die();
            }

            foreach($db->query("SELECT * FROM kunde_kauft_produkt WHERE produktID='$pid' AND benutzerID='".$user->id."'") as $row){
                echo "<script> window.alert('Sie haben dieses Produkt bereits gekauft.'); </script>";
                die();
            }
            
            $price = 9999999999999999999999999999999999;
            foreach($db->query("SELECT preis FROM produkt WHERE produktID='$pid'") as $row){
                $price = $row['preis'];
            }

            if($user->balance >= $price){
                $db->query("INSERT INTO kunde_kauft_produkt(benutzerID, produktID, datum, rabatt) VALUES('".$user->id."', '$pid', '".date("Y-m-d")."', '0')");
                $db->query("UPDATE kunde SET guthaben='".$user->balance - $price."' WHERE benutzerID='".$user->id."'");
                $user->balance -= $price;
                echo "<script> window.alert('Erfolgreich das Produkt mit der ID $pid gekauft.'); window.open('../', '_self'); </script>";
            } else {
                echo "<script> window.alert('Sie haben nicht genug Guthaben um dieses Produkt zu erwerben.');</script>";
            }

        }
    ?>

    </main>
    
</body>
</html>