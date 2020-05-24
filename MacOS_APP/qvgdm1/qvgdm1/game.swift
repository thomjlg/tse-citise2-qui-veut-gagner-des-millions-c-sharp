//
//  game.swift
//  qvgdm1
//
//  Created by Thomas JAULGEY on 22/05/2020.
//  Copyright © 2020 Thomas JAULGEY. All rights reserved.
//

import Cocoa

class partie: NSViewController {
    var etape = 0
    @IBOutlet weak var palier: NSTextField!
    
    @IBAction func gobackmenu(_ sender: Any) {
        self.dismiss(self)
    }
    
    
    @IBOutlet weak var barreprogression: NSLevelIndicator!

    
    @IBAction func validationRep(_ sender: Any) {
        barreprogression.intValue=Int32(etape+1)
        etape = etape+1
        if(etape>=10){
            palier.stringValue="Vous avez atteint le second palier à 48000€."
            palier.drawsBackground=true
        }else{
            if(etape>=5){
            palier.stringValue="Vous avez atteint le premier palier à 1500€."
            palier.drawsBackground=true
                }
        }
    }
    
    @IBAction func ValidRep2(_ sender: Any) {
        barreprogression.intValue=Int32(etape+1)
        etape = etape+1
        if(etape>=10){
            palier.stringValue="Vous avez atteint le second palier à 48000€."
            palier.drawsBackground=true
        }else{
            if(etape>=5){
            palier.stringValue="Vous avez atteint le premier palier à 1500€."
            palier.drawsBackground=true
                }
        }
    }
    @IBAction func ValidRep3(_ sender: Any) {
        barreprogression.intValue=Int32(etape+1)
        etape = etape+1
        if(etape>=10){
            palier.stringValue="Vous avez atteint le second palier à 48000€."
            palier.drawsBackground=true
        }else{
            if(etape>=5){
            palier.stringValue="Vous avez atteint le premier palier à 1500€."
            palier.drawsBackground=true
                }
        }
    }
    @IBAction func ValidRep4(_ sender: Any) {
        barreprogression.intValue=Int32(etape+1)
        etape = etape+1
        if(etape>=10){
            palier.stringValue="Vous avez atteint le second palier à 48000€."
            palier.drawsBackground=true
        }else{
            if(etape>=5){
            palier.stringValue="Vous avez atteint le premier palier à 1500€."
            palier.drawsBackground=true
                }
        }
        print(Question)
        
//        if let json = try JSONSerialization.jsonObject(with: data!) as? [[String:Any]] {
//            for item in question.json {
//                if let id = item["id"] as? [Int:Any] {
//                    print(question["nom"])
//                }
//            }
//        }
    }
    
    
    
    @IBOutlet weak var textQuestion: NSTextField!
    @IBAction func question_jeu(_ sender: Any) {
        self.textQuestion.stringValue = Question.nom
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
