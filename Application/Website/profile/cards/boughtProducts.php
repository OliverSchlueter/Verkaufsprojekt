<div class="card" id="boughtProducts">
    <h1 class="headline">Gekaufte Produkte</h1>
        <?php

            $dbRes = $db->query("SELECT * FROM kunde_kauft_produkt, produkt WHERE benutzerID='".$user->id."' AND produkt.produktID = kunde_kauft_produkt.produktID");
            if($dbRes->num_rows > 0){
                echo "
                <table>
                    <tr>
                        <th>Kauf ID</th>
                        <th>Produkt ID</th>
                        <th>Name</th>
                        <th>Datum</th>
                    </tr>";
                foreach($dbRes as $row){
                    echo "
                    <tr>
                        <td class='id'>".$row['kaufID']."</td>
                        <td class='id'>".$row['produktID']."</td>
                        <td>".$row['name']."</td>
                        <td>".$row['datum']."</td>
                        <td><a href='./?downloadProduct=true&id=".$row['produktID']."'><img title='Download' class='downloadImg' src='../assets/img/download.png' width='20px' height='20px'/></a></td>
                    </tr>";
                }
            } else {
                echo "Sie haben noch keine Produkte gekauft.";
            }
        
        ?>
        
    </table>
</div>