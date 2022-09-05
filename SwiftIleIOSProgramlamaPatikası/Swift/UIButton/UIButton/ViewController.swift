//
//  ViewController.swift
//  UIButton
//
//  Created by HAYDAR CAN COŞKUN on 2.09.2022.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var label:UILabel!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }
    
    @IBAction func didTapButton(_ sender: UIButton) {
        label.text = "Hoş Geldin!"
        sender.setTitleColor(UIColor.green, for: UIControl.State.normal)
        sender.setTitle("Text ve Renk Değişti", for: UIControl.State.normal)
    }

}

