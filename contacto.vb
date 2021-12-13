<!DOCTYPE html>
<html lang="es">

<head>
<title>Formulario</title>
</head>
<body>
    <a href="index.html"> Lab creativo </a> <!-- Esto seria el logo que redirige al home-->
    <ul>
        <a href="sobre mi.html"><li> Sobre mí</li></a> <br>
        <a href="servicios.html"><li>Servicios</li></a> <br>
        <a href="colaboraciones.html"><li>Colaboraciones</li></a><br>
        <a href="podcast.html"><li>Podcast</li></a><br>
        <a href="aportes.html"><li>Aportes</li></a><br>
        <a href="contacto.html"><li>Contacto</li></a><br>
        </ul>
        <h1>Formulario de Contacto</h1>
        
        <form action="">
        <fieldset> <br>
                        <label for="nombre"> Nombre: </label> 
                <input type="text"name="nombre"> <br> <br> </input>
            <laber for="email"> Email:</laber>
                <input type="email" name="email"> </input> <br> <br>
                <div> Estudiante </div><input type="radio" name="estudiante" value="estudiante"></input> <br>
                <div> Freelance</div> <input type="radio" name="estudiante" value="estudiante"> </input><br>
                <div>Trabajo en dependencia </div> <input type="radio" name="estudiante" value="estudiante"></input> <br> <br>
                    <legend> Dejanos tu consulta </legend>
                    Información sobre: <select name="Info">
                    <option value="cm">Community Manager</option>
                    <option value="dg">Diseño gráfico</option>
                    <option value="ux/ui">UX/UI</option>
                    <option value="front end">Font End</option>
                </select>  <br><br>
                
                Consulta: <br> <textarea name="comentario" cols="30" rows="10" > </textarea> <br>
                <div> Acepta terminos y condiciones</div> 
                <input type="checkbox" value="1"><br> <br>
                <input type="submit" value="enviar"> 
                        <input type="reset" value="deshacer"> 
                    </fieldset>

        </form>

</body>
</html>