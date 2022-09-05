//
//  ViewController.swift
//  UILabel
//
//  Created by HAYDAR CAN COŞKUN on 1.09.2022.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var label: UILabel!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        label.text  = "Merhaba, IOS!"
        label.font = UIFont.systemFont(ofSize: 17.0)
        label.textColor = UIColor.red
    }


}

