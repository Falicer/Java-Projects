<!DOCTYPE html>
<html lang="en">
    <head>
        <meta http-equiv="Content-Type"
              content="text/html;
              charset=UTF-8">
         <script src="validationform.js"></script> 
    </head>
<body>   
<?php
// define variables and set to empty values
$errors = array();
$name = $adres = $plaats = $postcode = $email = $password = $cpassword = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
   if (empty($_POST["name"])) {
     $errors['name'] = "Name is required";
   } else {
     $name = test_input($_POST["name"]);
     // check if name only contains letters and whitespace
     if (!preg_match("/^[a-zA-Z ]*$/",$name)) {
     $errors['name'] = "Only letters and white space allowed";
     }
   }
  
   if (empty($_POST["email"])) {
     $errors['email'] = "Email is required";
   } else {
     $email = test_input($_POST["email"]);
     // check if e-mail address is well-formed
     if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
       $errors['email'] = "Invalid email format";
     }
   }
   if (empty($_POST["postcode"])) {
     $errors['postcode'] = "Postcode is required";
   } else {
     $postcode = test_input($_POST["postcode"]);
     // check if name only contains letters and whitespace
     if (!preg_match('/^[1-9]{1}[0-9]{3}[A-Z]{2}$/', $postcode)) {
       $errors['postcode'] = "ongeldige postcode";
     }
   }
    // checks password
    if (empty($_POST["password"])) {
     $errors['password'] = "password is required";
   }
    if(!empty($_POST["password"]) && ($_POST["password"] == $_POST["cpassword"])) {
    $password = test_input($_POST["password"]);
    $cpassword = test_input($_POST["cpassword"]);
    if (strlen($_POST["password"]) <= '8') {
        $errors['password'] = "Your Password Must Contain At Least 8 Characters!";
    }
    elseif(!preg_match("#[0-9]+#",$password)) {
        $errors['password'] = "Your Password Must Contain At Least 1 Number!";
    }
    elseif(!preg_match("#[A-Z]+#",$password)) {
        $errors['password'] = "Your Password Must Contain At Least 1 Capital Letter!";
    }
    elseif(!preg_match("#[a-z]+#",$password)) {
        $errors['password'] = "Your Password Must Contain At Least 1 Lowercase Letter!";
    }
}
    elseif(!empty($_POST["password"])) {
    $errors['cpassword'] = "Please Check You've Entered Or Confirmed Your Password!";
}
    //mysql conn.
 if (!$errors) {
        $servername = "localhost";
        $username = "root";
        $password = "";
        $dbname = "gagastore";

        // Create connection
        $conn = new mysqli($servername, $username, $password, $dbname);
        // Check connection
        if ($conn->connect_error) {
            die("Connection failed: " . $conn->connect_error);
        }

        // Escape user inputs for security



        // insert data
        $sql="INSERT INTO klant (naam, adres, postcode, woonplaats, email)".
        "VALUES('$_POST[name]','$_POST[adres]','$_POST[postcode]','$_POST[plaats]','$_POST[email]')";

        $result = mysql_query($sql);	
        if ($conn->query($sql) === TRUE) {
            echo "New record created successfully!";
        } else {
            echo "Error: " . $sql . "<br>" . $conn->error;
}


//if ($conn->query($sql2) === TRUE) {
//    echo "New record created successfully";
//} else {
//    echo "Error: " . $sql . "<br>" . $conn->error;
//}

$conn->close();
    }

}


function test_input($data) {
   $data = trim($data);
   $data = stripslashes($data);
   $data = htmlspecialchars($data);
   return $data;
}


?>

        <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>"> 
                Naam: <input type="text"
                name="name"  />
                <span class="error"> <?php  if(isset($errors['name'])) echo $errors['name'] ?></span><br />
                Adres:<input type="text"
                name="adres"  /><br />
                Plaats:<input type="text"
                name="plaats"  /><br />
                Postcode:<input type="text"
                name="postcode"  />
                <span class="error"> <?php  if(isset($errors['postcode'])) echo $errors['postcode'] ?></span><br />
                email:<input type="text"
                name="email"  />
                <span class="error"> <?php  if(isset($errors['email'])) echo $errors['email'] ?></span><br />
                Wachtwoord:<input type="password"
                name="password"  />
                <span class="error"><?php  if(isset($errors['password'])) echo $errors['password'] ?></span><br />
                Opnieuw wachtwoord:<input type="password"
                name="cpassword"  />
                <span class="error"><?php  if(isset($errors['cpassword'])) echo $errors['cpassword'] ?></span><br />
                <input type="hidden" name="submit" value="true" />
                <input type="submit" id="submit" value="Aanmelden" />   
        </form>
</body>
</html>