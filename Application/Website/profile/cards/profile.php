<div class="card" id="profile">
    <h1 class="headline">Profil</h1>
    <p>ID: <span class="value"><?= $user->id ?></span></p>
    <p>Name: <span class="value"><?= $user->firstName ?> <?= $user->lastName ?><span></p>
    <p>Nickname: <span class="value"><?= $user->nickName ?><span></p>
    <p>Email: <span class="value"><?= $user->email ?><span></p>
    <p>Geburtstag: <span class="value"><?= $user->birthday ?><span></p>
    <p>Erstelldatum: <span class="value"><?= $user->creationDate ?><span></p>
    <?php 
        if($user instanceof Customer){
            echo "<p>Guthaben: <span class='value'>".$user->balance." €<span></p>";
        }

        if($user instanceof Autor){
            echo "<p>Entwicklerstatus: <span class='value'>".$user->devStatus."<span></p>";
        }
    ?>
</div>