/**
 * \brief constants.h
 * \author DEGEN Marie
 * \date Oct 14, 2017
 */
#ifndef CONSTANTS_H_
#define CONSTANTS_H_

//Style for label
#define STYLE_BEGIN_HEADER "<font=Tizen:style=condensed font_size=30>"
#define STYLE_END_HEADER "</font/>"
#define STYLE_TEXT_BEGIN "<align=center>"
#define STYLE_TEXT_END "</align>"

//Constants
#define HEART_RECORDING "Heart Recording"
#define HEART_RATE_SCREEN "Searching for your heart rate, please wait."
#define BLUETOOTH_SCREEN "The data are being sent to the main application please wait..."
#define STOP_BUTTON_HPM "HPM"
#define STOP_BUTTON_TIMER "00:00"
#define STOP_BUTTON_RECORDING "Recording..."
#define STOP_BUTTON "STOP"
#define EXIT_BUTTON "EXIT"
#define START_BUTTON_LABEL "Press the start button to begin the heart rate recording."
#define START_BUTTON "START"
#define END_SCREEN_MESSAGE "It's done. Thanks."

//Bluetooth constants
#define UUID "00001101-0000-1000-8000-00805F9B34FB"


//Macro for the header style
#define style_header(x) STYLE_BEGIN_HEADER x STYLE_END_HEADER

//Macro for the text style
#define style_text(x) STYLE_TEXT_BEGIN x STYLE_TEXT_END

#endif /* CONSTANTS_H_ */
