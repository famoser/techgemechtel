<?php
/**
 * Created by PhpStorm.
 * User: famoser
 * Date: 04/04/2016
 * Time: 21:14
 */

use Techgemechtel\MVCExample\Controllers\HomeController;

/*** very simple autoloader
 * php calls this method if it need to use a class it does not know yet. $class is the full class name with namespaces.
 * there are even easier ways to do this, look up composer if you're interested
 ***/
spl_autoload_register(
	function ($class) {
		// project-specific namespace prefix
		$prefix = 'Techgemechtel\\MVCExample';
		//remove the prefix
		$noPrefix = str_replace($prefix, "", $class);
		//include the file
		require $filePath = __DIR__ . str_replace("\\", DIRECTORY_SEPARATOR, $noPrefix) . ".php";
	}
);

//construct the controller
$controller = new HomeController($_SERVER["REQUEST_URI"]);
//execute the application
echo $controller->execute();