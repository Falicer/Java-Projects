<!DOCTYPE html>
<html lang="en">
    <head>
        <meta http-equiv="Content-Type"
              content="text/html;
              charset=UTF-8">
         <script src="validationform.js"></script> 
    </head>
    <body>
        <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
                Naam: <input type="text"
                name="username"  /><br />
                Adres:<input type="text"
                name="adres"  /><br />
                Postcode:<input type="text"
                name="postcode"  /><br />
                email:<input type="email"
                name="email"  /><br />
                Wachtwoord:<input type="password"
                name="pwd1"  /><br />
                Opnieuw wachtwoord:<input type="password"
                name="pwd2"  /><br />
                <input type="hidden" name="submit" value="true" />
                <input type="submit" id="submit" value="Aanmelden" />   
        </form>
        
<?php
// define variables and set to empty values
$name = $email = $gender = $comment = $website = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $username = test_input($_POST["username"]);
  $email = test_input($_POST["email"]);
  $adres = test_input($_POST["adres"]);
  $postcode = test_input($_POST["postcode"]);
  $pwd1 = test_input($_POST["gender"]);
}

function test_input($data) {
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}
?>
</body>
</html>