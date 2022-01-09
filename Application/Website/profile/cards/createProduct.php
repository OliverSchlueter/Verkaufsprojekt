<div class="card" id="createProduct">
    <h1 class="headline">Produkt erstellen</h1>
    <form action="" method="post">
        <label for="cpName" class="label">Produktname:</label>
        <input type="text" name="cpName" id="cpName" placeholder="Produktname" required>
        
        <label for="cpID" class="label">Wunsch ID:</label>
        <input type="text" name="cpID" id="cpID" placeholder="P1234" minlength="5" maxlength="5">

        <label for="cpPreis" class="label">Preis (€):</label>
        <input type="number" name="cpPrice" id="cpPrice" placeholder="xx,xx" min="0" step="0.01" required>

        <label for="cpDescription" class="label">Beschreibung:</label>
        <textarea name="cpDescription" id="cpDescription" placeholder="Lorem ipsum dolor sit amet consectetur adipisicing elit. Nemo consequatur veniam recusandae pariatur fugiat quas obcaecati ex accusamus cupiditate mollitia eius maxime nam eligendi, alias consectetur officia esse? Nisi, amet." required></textarea>

        <label for="cpFile" class="label">Produktdatei:</label>
        <input type="file" name="cpFile" id="cpFile" accept=".zip,.rar" multiple>

        <button type="submit" name="cpSubmit" id="cpSubmit">Produkt erstellen</button>
    </form>
</div>


<?php 

if(isset($_POST['cpSubmit'])){
    $name = $_POST['cpName'];
    $price = $_POST['cpPrice'];
    $description = $_POST['cpDescription'];
    $releaseDate = date("Y-m-d");

    $wishID = "";
    if(isset($_POST['cpID'])){
        $wishID = $_POST['cpID'];
    }

    $id = "";

    if($wishID != "" && !in_array($wishID, getAllProductIDs($db))){
        $id = $wishID;
    } else {
        $id = getNewProductID($db);
    }

    $db->query("INSERT INTO produkt VALUES('$id', '$name', '$price', '$description', '$releaseDate')");
    $db->query("INSERT INTO autor_schreibt_produkt VALUES('".$user->id."', '$id')");

    echo "<script>window.alert('Produkt erfolgreich veröffentlicht. Die ID lautet: $id'); window.open('./', '_self');</script>";
}

?>