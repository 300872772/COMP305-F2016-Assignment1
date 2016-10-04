using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/**
 * This is a retro shooter game 
 * 
 * @FileName: MenuController.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 03-October-2016
 * @description: this file is MenuController cs file for the game
 */

/**  
* <summary>  
* This is the MenuController class to control the first screen.  
* </summary>  
*   
* @class MenuController  
*/

public class MenuController : MonoBehaviour {

	/**
        * <summary>
        * This is the method for starting the blackworldController class which initiates value
        * </summary>
        * 
        * @method Start
        * @returns {void} 
        */
	void Start () {
	
	}
	
	/**
        * <summary>
        * This method is called once per frame.
        * </summary>
        * 
        * @method Update
        * @returns {void} 
        */
	void Update () {
	
	}
	public void StartButton_Click(){
		SceneManager.LoadScene ("Game");
	}
}
