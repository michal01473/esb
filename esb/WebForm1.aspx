<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="esb.WebForm1" %>

<!DOCTYPE html>
<html>
<head>
    <title>Logowanie</title>
    <link rel="stylesheet" href="css/text.css" type="text/css" />
	<meta charset="utf-8" />
</head>
<body>
    <div class="container">

        <form id="signup">

            <div class="header">

                <h3>Logowanie do systemu</h3>

                <p>Wypełnij pola, aby się zalogowac</p>

            </div>

            <div class="sep"></div>

            <div class="inputs">

                <input type="email" placeholder="Login" autofocus />

                <input type="password" placeholder="Hasło" />

                <div class="checkboxy">
                    <input name="cecky" id="checky" value="1" type="checkbox" /><label class="terms">Zapamiętaj mnie</label>
                </div>

                <a id="submit" href="procownicy.html">ZALOGUJ</a>

            </div>

        </form>

    </div>
</body>
</html>