//
//  ViewController.swift
//  UITextfField
//
//  Created by HAYDAR CAN COŞKUN on 4.09.2022.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var userNameTextField:UITextField!
    @IBOutlet weak var userPasswordTextField:UITextField!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    @IBAction func didTapLogicButton(_ sender: UIButton)
    {
        print("Username: \(String(describing: userNameTextField.text))")
        print("Password: \(userPasswordTextField.text ?? "Şifre Girilmedi")")
    }

    
}

