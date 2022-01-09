<div class="card" id="writtenProducts">
    <h1 class="headline">Veröffentlichte Produkte</h1>
    <script src="../assets/js/deleteProduct.js"></script>

        <?php
            $dbRes = $db->query("SELECT * FROM autor_schreibt_produkt, produkt WHERE benutzerID='".$user->id."' AND produkt.produktID = autor_schreibt_produkt.produktID");
            if($dbRes->num_rows > 0){
                echo "
                    <table>
                    <tr>
                        <th>Produkt ID</th>
                        <th>Name</th>
                        <th>Datum</th>
                    </tr>";
                foreach($dbRes as $row){
                    echo "
                    <tr>
                        <td class='id'>".$row['produktID']."</td>
                        <td>".$row['name']."</td>
                        <td>".$row['veroeffentlichungsdatum']."</td>
                        <td><a href='./?delProduct=true&id=".$row['produktID']."'><img title='Löschen' class='delImg' src='../assets/img/delete.png' width='20px' height='20px'/></a></td>
                    </tr>";
                }
            } else {
                echo "Sie habe noch keine Produkte veröffentlicht.";
            }


            if(isset($_GET['delProduct'])){
                $id = $_GET['id'];
                $db->query("DELETE FROM kunde_kauft_produkt WHERE produktID='$id'");
                $db->query("DELETE FROM autor_schreibt_produkt WHERE produktID='$id'");
                $db->query("DELETE FROM produkt WHERE produktID='$id'");

                echo "<script>window.alert('Produkt erfolgreich gelöscht. Die ID war: $id'); window.open('./', '_self');</script>";
            }
        ?>
        
    </table>
</div>