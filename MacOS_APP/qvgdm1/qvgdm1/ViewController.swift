//
//  ViewController.swift
//  qvgdm1
//
//  Created by Thomas JAULGEY on 22/05/2020.
//  Copyright © 2020 Thomas JAULGEY. All rights reserved.
//

import Cocoa

class ViewController: NSViewController {
    @IBOutlet weak var help: NSTextField!
    @IBAction func regle(_ sender: Any) {
        if(self.help.isHidden==false){
            self.help.isHidden=true
        }else{
            self.help.isHidden=false
        }
    }
 
    
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
    }

    override var representedObject: Any? {
        didSet {
        // Update the view, if already loaded.
        }
    }


}

