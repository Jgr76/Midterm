using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour {

	public Sprite fullHeart;
	public Sprite almostFullHeart;
	public Sprite nearFullHeart;
	public Sprite underTheWingsHeart;
	public Sprite threeQuartersHeart;
	public Sprite underThreeQuartersHeart;
	public Sprite almostHalfHeart;
	public Sprite halfHeart;
	public Sprite lessThanHalfHeart;
	public Sprite nearlyInviHeart;
	public Sprite barelyHeart;
	public Sprite quarterHeart;
	public Sprite lessThanQueaterHeart;
	public Sprite almostdeadHeart;
	public Sprite soCloseToDeathHeart;
	public Sprite soVeryClosetoDeathHeart;
	public Sprite deadHeart; 

	public Image heartsUI;

	private PenguinController player;

	// Use this for initialization
	void Start () {
		
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PenguinController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (player.curHealth == 16) {
			
			heartsUI.sprite = fullHeart;

		}
		if (player.curHealth == 15) {
			
			heartsUI.sprite = almostFullHeart;

		}
		if (player.curHealth == 14) {
			
			heartsUI.sprite = nearFullHeart;

		}
		if (player.curHealth == 13) {
			
			heartsUI.sprite = underTheWingsHeart;

		}
		if (player.curHealth == 12) {

			heartsUI.sprite = threeQuartersHeart;

		}
		if (player.curHealth == 11) {

			heartsUI.sprite = underThreeQuartersHeart;

		}
		if (player.curHealth == 10) {

			heartsUI.sprite = almostHalfHeart;

		}
		if (player.curHealth == 9) {

			heartsUI.sprite = halfHeart;

		}
		if (player.curHealth == 8) {

			heartsUI.sprite = lessThanHalfHeart;

		}
		if (player.curHealth == 7) {

			heartsUI.sprite = nearlyInviHeart;

		}
		if (player.curHealth == 6) {

			heartsUI.sprite = barelyHeart;

		}
		if (player.curHealth == 5) {

			heartsUI.sprite = quarterHeart;

		}
		if (player.curHealth == 4) {

			heartsUI.sprite = lessThanQueaterHeart;

		}
		if (player.curHealth == 3) {

			heartsUI.sprite = almostdeadHeart;

		}
		if (player.curHealth == 2) {

			heartsUI.sprite = soCloseToDeathHeart;

		}
		if (player.curHealth == 1) {

			heartsUI.sprite = soVeryClosetoDeathHeart;

		}
		if (player.curHealth == 0) {

			heartsUI.sprite = deadHeart;

		}
	}
}
