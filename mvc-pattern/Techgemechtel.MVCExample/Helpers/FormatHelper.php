<?php
/**
 * Created by PhpStorm.
 * User: famoser
 * Date: 04/04/2016
 * Time: 21:56
 */

namespace Techgemechtel\MVCExample\Helpers;


class FormatHelper {
	public static function displayDate($value)
	{
		return date("Y.m.d", strtotime($value));
	}
}